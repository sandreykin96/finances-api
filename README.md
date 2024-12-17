#Finances
Для работы в локальном окружении: 1)docker-compose 2)build docker-compose up

При разработке стартовым проектом выбрать проект docker-compose.

Миграци происходят автоматически при запуске проекта.

Если нужно провести миграции вручную - так как два проекта - 
1)Изменить свой рабочий каталог на тот, который содержит миграции (Finances.Dal) 
2)Выполнить команду добавления миграций и указать свой стартовый проект. dotnet ef migrations add Initial --startup-project ../Finances.Api/Finances.Api.csproj 
3) Для обновления таблицы dotnet ef database update --startup-project ../Finances.Api/Finances.Api.csproj

Для запуска интеграционных тестов не забыть запустить локальное окружение 1) docker-compose build 2) docker-compose up

Если dotnet ef не сработает, то нужно выполнить команду dotnet tool install --global dotnet-ef