# ИНФОРМАЦИИ ЗА ПРОЕКТОТ
Сајтот е изработен во .NET 6, за фронт-енд се користи RazorPages со Bootstrap, а базата на податоци е MySQL.
- Server: Localhost via UNIX socket
- Server type: MariaDB
- Server connection: SSL is not being used
- Server version: 10.4.19-MariaDB - Source distribution
- Protocol version: 10
- User: root@localhost
- Server charset: UTF-8 Unicode (utf8mb4)

Миграциите се прават во фолдерот Data/Migrations.
За превод користиме Localization од Microsoft.AspNetCore.Localization и еден en.po фајл во кој се преведени зборовите кои најчесто се јавуваат на сајтот.
Формата за регистрација ќе биде достапна само за да го регистрираме првиот корисник, потоа може да се искоментира цела форма или Authorize да се додаде на тој View.
# ДОКУМЕНТАЦИЈА ЗА КОРИСТЕЊЕ НА АДМИН ПАНЕЛОТ
За пристап до админ панелот не постои начин преку самиот сајт. Единствен пристап е преку URL адресата imenasajt.mk/Account/Login. Формата за регистрација е затворена.
### ДОДАВАЊЕ НА УМЕТНИЧКО ДЕЛО:
За додавање на слика кликаме на копчето „Додади уметничко дело“ и се отвара форма за додавање на нова слика. Сите полиња се задолжителни. Формата е направена така што полињата како „Наслов“, „Опис“ и „Техника“ треба да бидат пополнети на македонски и на англиски јазик. Форматот се внесува на следен начин 50x50 без додавање на цм или cm. Потоа се избира дали сликата е наменета за продажба или не, доколку е за продажба таа ќе биде прикажана во Галерија, доколку не е на продажба ќе биде прикажана во Експонанти. На последното поле се избира слика од делото кое се додава.
### ИЗМЕНУВАЊЕ НА ВЕЌЕ ПОСТОЕЧКО УМЕТНИЧКО ДЕЛО:
За изменување на веќе постоечка слика се клика на копчето „Измени“ на избраната слика. Потоа се отвара форма иста како таа за додавање на слика, разликата е во тоа што информациите се веќе пополнети, освен последното поле кое е за избирање на слика од делото. При секое изменување тоа поле мора повторно да се додава бидејќи не се дозволува автоматско пополнување на фајлови.
### ДЕТАЛИ:
Со кликање на копчето детали или на името на уметничкото дело се прикажуваат сите детали за сликата.

### ДОДАВАЊЕ НА БИОГРАФИЈА:
За додавање на биографија се избира Биографија од навигациското мени и потоа се клика на копчето „Додади биографија“. Важна напомена е тоа дека доколку веќе има постоечка биографија, препорачливо е да се измени постоечката наместо да се додаде нова. При кликање на наведеното копче ќе се отвори форма со три полиња од кој две се текст полињата, првото поле е за биографија на македонски јазик, второто за англиски јазик. Третото поле е исто како и сликите, се вметнува слика која ќе стои до биографијата, во нашиот случај слика од авторот.
### ИЗМЕНУВАЊЕ НА ВЕЌЕ ПОСТОЕЧКА БИОГРАФИЈА:
За изменување на веќе постоечка биографија се клика на копчето „Измени“ до биографијата. Потоа се отвара истата форма како и за внес на биографија, разликата е во тоа што информациите се пополнети, единствено потребно е да се избере сликата од ново од иста причина како и при изменувањето на делата.
### ПРОМЕНА НА ЛОЗИНКА:
За промена на лозинка се клика на „Поставки“ од навигациското мени. Потоа се избира копчето „Промени“ веднаш под текстот Лозинка. Се отвара форма на која се внесуваат старата лозинка, новата лозинка и потврда за новата лозинка.
# НАВИГАЦИЈА НА САМИОТ САЈТ:
При прво отварање на сајтот, првата страница која ќе се прикаже е Галерија која е всушност и почетна страница на самиот сајт.
- На страницата Галерија се прикажани сите дела кои се наменети за продажба. Секое уметничко дело е прикажано со слика од делото и наслов веднаш под него. Со кликање на самата слика или на насловот на делото се отвара нова страница на која се прикажани деталите на делото како Наслов, Опис, Техника на цртање, Формат.
- Страница која работи на потполно ист начин е Експонати. Уметничките дела прикажани на таа страница не се на продажба и страницата работи на ист начин како Галерија. Со клик на името на делото или на сликата од делото се пристапува до деталите од истото.
- На страницата Биографија е прикажана слика од уметникот и негова биографија.
- На страницата Контакт достапни се сите начини на кој може да се контактира уметникот.