# -BeamCalculatingWinForms
Расчет и построение эпюр моментов в двухопорной балке
Перейдите в папку bin/Debug, откройте Sopromat.exe, откроется Windows форма. Далее следуйте инструкциям и получите расчет эпюры моментов в формате графика, 
для создания данного расчетного комплекса использовались две составляющие, сама Windows форма и консольное приложение BeamTest, в котором производится расчет и отладка расчетов, данные из Windows формы передаются в 
BeamTest, где обрабатываются и возвращаются в формате коллекции List<GraphMoments>, на основании которой происходит построение графика снова в WinForms. 
В данном проекте реализована ООП составляющая балки, для более детального рассмотрения ознакомьтесь с проектом BeamTest. 
Данный проект ориентирован на быстрое получение эпюр моментов в двухопорной балке, что может быть полезно как студентам так и практикующим инженерам для быстрого выполнения простых расчетов
