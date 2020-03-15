# Notification-Control
Задача:
                Реализовать форму отображения уведомлений. Уведомления добавляются / удаляются через эту же форму.

Функционал: 
                - Возможность добавить уведомление в список с указанным наименованием и описанием. Уведомление добавляется непрочитанным в конец списка. В качестве даты создания устаналивается DateTime.Now.
                - С помощью гиперссылки «прочитано»/«не прочитано» в списке уведомлений инвертировать одноименное состояние уведомления. Соответственно меняется отображение события на форме – «синее» - не прочитанное, «серое» - прочитанное (см. скриншот ниже).
                - С помощью кнопки «Очистить» - удалить все уведомления с формы.

Атрибуты уведомления:
                - Наименование банка (в заголовке уведомления, «АО КБ Ассоциация» на скриншоте)
                - Описание уведомления (выводится под заголовком – «Данные загружены в систему» на скриншоте)
                - Дата/время создания (выводится в правом верхнем углу)
                - Состояние «Прочитано» (типа bool).

Цвета:
                - #84C7DA : левая граница непрочитанного уведомления
                - #E2F1FF : заливка непрочитанного уведомления
                - #A3A9B2 : левая граница прочитанного уведомления
                - #0064BF : цвет заливки кнопки
                - #131313 : цвет шрифта.