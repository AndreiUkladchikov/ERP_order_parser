# Тестовое задание. Получение заказов от клиентов и отправка в текущую ERP систему

Попробовал описать задачу в виде модели С4 (частично). 

Реализовал в общем виде структуру сервиса по обработке заказов. За основу взял Onion архитектуру.

Схема 1. Описание бизнес-задачи в общем виде.
Я предлагаю разделить задачу на две условных части:
- Получение заказов;
- Обработка заказов.
Получение заказов.
Необходимые модули:
- SMTP сервер для обработки писем
- Телеграм бот
- Веб-сервис
- СRON сервис для создания заданий веб-сервису на опрос клиентов
- Auth Database. БД для хранения списка клиентов (email, telegram), ключей авторизации к API клиентов, расписания для CRON.
- Брокер сообщений для создания очереди заказов от клиентов.
Обработка заказов.
Получение заказа из очереди, для обработки писем и сообщений из Telegram – верификация клиента с данными в базе для авторизации.
Принцип работы.
Заказы от клиентов через почту и телеграм попадают в очередь. Заказы на FTP и API клиентов  собирает веб сервис по расписанию из базы данных для авторизации. После получения заказы добавляются в очередь, откуда их берет сервис для обработки.
Узким местом пока является только сервис для обработки, лучше реализовывать на микросервисах, чтобы при необходимости можно было увеличить число запущенных контейнеров. Сервис по сбору заказов и AuthDb также можно будет реплицировать, при необходимости после CRON сервиса встроить еще одну очередь.

Схема 2.
Сервис по обработке заказов:
- Получаем необработанный заказ из очереди (Message Receiver)
- Передаем его в OrderService на обработку. Если не заполнен ClientId- пробуем получить его из сервиса авторизации через провайдер. При необходимости заводим нового клиента.
- Заказ пропускаем через парсер
- OrderBuilder и Repository – модули для интеграции с текущей ERP системой. Перед созданием заказа в ERP надо валидировать данные из заказа с сущностями в системе.

![order_system drawio](https://github.com/AndreiUkladchikov/ERP_order_parser/assets/73438327/42c9f8e2-f9a8-4fb4-bc4b-d4d243b008c5)
