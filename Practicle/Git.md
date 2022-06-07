# Изменить origin адрес репозитория двумя способами:

1. Первый способ задать url репозитория:

использовать команду `git remote set-url origin`, например:

git remote set-url origin git@github.com:vicman-wi/wi-backend.git

2. Второй способ:

Отредактировать файл `.git/config` : секция [remote "origin"] параметр - url. 

 
Эти два способа идентичные. Т.е. вызов команды git remote set-url origin заменит содержимое git конфига.