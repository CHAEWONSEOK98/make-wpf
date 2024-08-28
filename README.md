# make-wpf

## WPF Study

**Content**

- [ ] 1. Button 이동
- [ ] 2. ControlTemplate
- [ ] 3. DataTemplate
- [ ] 4. Trigger
- [ ] 5. ContentControl
- [ ] 6. ListBox
- [ ] 7. ListBoxItem
- [ ] 8. ItemsControl
- [ ] 9. CustomControl
- [ ] 10. GetContainerItemForOverride
- [ ] 11. AutoGrid.Core
- [ ] 12. CommunityToolkit
- [ ] 13. NugetPackage

## 1. Button
- Content -> 내용

## 2. ControlTemplate
- Template -> ControlTemplate
- ControlTemplate -> TargetType

## 3. DataTemplate

## 4. Trigger

## 5. ContentControl

**대부분의 Control은 ContentControl을 상속받아서 각각 자신의 Content(object)를 갖고 있고, <br/>
Object를 Content들이 갖고 있는 Template속 ContentPresenter에 뿌려준다.**

| 클래스 | 부모 클래스 |
|:------|:-------------|
| Button | ButtonBase |
| CheckBox | ContentControl |
| RadioButton | ContentControl |
| ToggleButton | ContentControl |
| ListBoxItem | ContentControl |
| Lable | ContentControl |
| ComboBoxItem | ContentControl |
| ListViewItem | ContentControl |
| TreeViewItem | ContentControl |
| GroupBox | ContentControl |
| Window | ContentControl |
| UserControl | ContentControl |
| ScrollViewer | ContentControl |
