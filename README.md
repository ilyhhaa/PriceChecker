
Good day to u!

I decided to make a small price tracker to track the prices of components for my computer.
Technologies used:
.Net Framework, WinForms,Selenium,Newtonsoft.

Instructions for use:
So, when you start the project a window opens, with three fields Name,URL,Selector.
On the right side there is a test button to test the correctness of the data obtained with Xpath.
Slidebar to set the frequency of price check and data update in the sheet.
The Add and Remove buttons respectively add or remove a tracking object from the tracking list.

Below there is a field with which the tracked items are listed.

The Start Tracking button starts the process of updating the price data after a period of time by passing Current Value - showing the current data (price),PrevPrice - previous values, LastChecked - last request to update the data, Last Changed - last change of the data received from outside.
 
Filling fields:
Name - takes an arbitrary text value, this is the name you want to give to the tracked object.
URL - field to send a link to the product page.
Selector - The field to which you need to pass the Xpath code of the item that contains the data to be tracked.

How do I actually get the necessary Xpath code for an element? The easiest way is to download the extension for google chrome at the link:

https://chromewebstore.google.com/detail/selectorshub/ndgimibanhlabgdgjcpbbndiehljcpfh?pli=1

Or install a similar one. The extension allows you to select the desired element and get its Xpath code by right-clicking on it.

Copying the Xpath code paste it into the Selector field.

Usage:
After filling in all the fields, click the Test button to check if the passed Xpath code works, then you can click the Add button and add the object to the list of tracked objects. The start button will start the tracking and the slidebar will allow you to set the frequency of data updates.






 

 
Доброго времени суток!

Решил сделать небольшой  отслеживатель цен, чтобы отслеживать цены на комплектующие для своего компьютера.
Используемые техногологии:
.Net Framework, WinForms,Selenium,Newtonsoft.

Инструкция к использованию:
Итак, при запуске проекта открывается окно, с тремя полями Name,URL,Selector.
Справа находится кнопка тест, для тестирования корректности полученных с помощью Xpath данных.
Slidebar для установки частоты проверки цены и обновления данных в листе.
Кнопка Add и Remove соответственно добавляют или удаляют объект отслеживания из списка отслеживания.

Ниже есть поле с в котором перечислены отслеживаемые товары.

Кнопка Start Tracking , начинает процесс обновления через промежуток времени данных цены, передавая Current Value - отображающую текущие данные (цену),PrevPrice - предыдущие значения, LastChecked - последний запрос на обновление данных, Last Changed - последнее изменение данных полученных из вне.
 
Заполнение полей:
Name - принимает произвольное текстовое значение, это имя по которому выхотите дать отслеживаемому объекту.
URL - поле для передачи ссылки на страницу товара.
Selector - Поле в которое необходимо передать Xpath code, элемента, в котором находятся требующие отслеживания данные.

Как собственно получить необходимый Xpath code для элемента? Наиболее просто способ - скачать расширение для google chrome по ссылке:

https://chromewebstore.google.com/detail/selectorshub/ndgimibanhlabgdgjcpbbndiehljcpfh?pli=1

Или установить схожее. Расширение предоставляет возможность выделить необходимый элемент и получить его Xpath code при нажатии правой кнопки мыши.

Скопировав Xpath code  вставляем его в поле Selector.

Использование:
После заполнения всех полей, нажмите кнопку Test, чтобы проверить работает ли переданный Xpath code, далее можно нажать кнопку Add и добавить объект в перечень отслеживаемых. Кнопка старт запустит отслеживание, а slidebar помжет настроить частту обновления данных.
