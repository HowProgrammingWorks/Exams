# Экзамен по материалу SEF1

- Для начала, каждый должен иметь github аккаунт, если нет - регистрируемся
- Посмотрите семинары с консультациями к экзамену:
  - https://youtu.be/eYjf_WrYAqk
  - https://youtu.be/05iTAT_t6cI
- Посмотрите видео по антипаттернам и рефакторингу:
  - https://www.youtube.com/playlist?list=PLHhi8ymDMrQb3PVcPFAUI-ZgtAMkpq9yV
- Если кто потерялся, то материалы курса тут:
  - https://github.com/HowProgrammingWorks/Index/blob/master/Courses/Fundamentals.md
- Сделайте форк этого репозитория https://github.com/HowProgrammingWorks/Exams
- Склонируйте репозиторий к себе на машину или вы можете делать задания прямо в веб-интерфейсе гитхаба
- В своем форке сделайте ветку `exams` и в ней дальше выполните задания
- В директории `Tasks` есть 38 заданий, выберите себе любые 2 из них
- В файле с заданием написан плохой код, вам нужно его оптимизировать в несколько шагов
- Код задания работает, и выдает правильный результат, вам нужно исправлять файл, но не сломать код
- Для работы с кодом вам может понадобиться:
  - Runtime - [Node.js](https://nodejs.org/en/) с менеджером пакетов: [npm](https://www.npmjs.com/)
  - Линтер - проверка стиля кода и анализ синтаксиса - [ESLint](http://eslint.org/)
  - VCS - система контроля версий - [GitHub](https://github.com/), [Git](https://git-scm.com/), [GUI](https://desktop.github.com/)
  - IDE - редактор или среда разработки, например: [Vim](http://www.vim.org/), [Visual Studio Code](https://code.visualstudio.com/)
- Используйте тесты из каталога `Tests` для проверки решений. Чтобы запустить пример с тестами:
  - в папке с кодом пишем, например: `node size.js`
  - получаем в терминале: `Passed: 11 of 11` или ошибки
- Ваша задача улучшить:
  - Понятность кода,
  - Стиль,
  - Простоту,
  - Качество,
  - Поддерживаемость,
  - Надежность,
  - Тестируемость
- Найдите себе двух друзей из группы и сделайте перекрестный ревью кода в пул-реквестах
- Тут чеклист частых ошибок (после ревью они точно должны быть исправлены):
  - Не модифицируйте входные параметры функций
  - Предпочитайте стрелочніе функции для JavaScript и `lambda` для `Python`
  - Используйте eslint и prettier для JavaScript с нашими настройками (см. в корне этого репозитория)
  - Предпочтительно использвать `for..of` или `for` по переменной или `Array/map`, и избегайте `for..in` и `forEach`
  - Используйте промежуточные идентификаторы разделяя длинные выражения
  - Предпочитайте `const` и в крайнем случае используйте `let`, но никогда не используйте `var`
  - Преобразуйте все магические значения в константы
  - Придерживайтесь правил именования идентификаторов
  - Хорошо подумайте над именами идентификаторов, чтобы при прочтении кода всем было понятно их содержимое
  - Не делайте слишком длинных функций
  - Не делайте большую стопку if-выражений, вместо этого используйте массивы и объекты
- Если вы пишете **не** на js, то переведите код на свой язык, насколько это возможно
- Каждый шаг делайте отдельным коммитом, важно не переписать с нуля, а именно пошагово улучшать. На второй консультации я показал пример того, как нужно оптимизировать код
- Когда закончите - сделайте пул-реквест в мой репозиторий и заполните форму, в которой укажите ссылку на свой форк с готовым заданием: https://forms.gle/qmbwSNCSbtDf6g4X7
- Всем успехов в Новом Году и на экзамене!
