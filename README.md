Метод 1:
Создание первоначального массива.
Предлагается пользователю ввести количество элементов массива, в дальнейшем сами элементы.

Метод 2:
Цикл for (i < длины изначального массива).
Внутри цикла проверка условия if (количество знаков элемента i <= 3)
если да, то элемент i изначального массива становится элементом j второго массива.
если нет, то ничего не происходит
После увеличивается переменная j на 1 и возвращается к циклу for в котором переменная i увеличивается на 1.
Получаем второй массив, состоящий из элементов изначального массива, в которых количество знаков меньше, либо равно 3.