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

## 6. ListBox
- 상속
  - Control > ItemsControl > Selector > ListBox
 
- Property : ItemsSource, SelectedItem, SelectionMode
  - ItemsSource : ListBoxItem을 생성하기 위한 컬렉션
  - SelectedItem : 선택된 아이템 반환 (여러개 인 경우 첫 번째 아이템 반환, 선택 항목이 없는 경우 null 반환)
  - SelectionMode : ListBox 의 선택 동작 정의
  - DisplayMemberPath : ListBoxItem의 Content로 표시할 Path 이름. 바인딩 된 아이템 Source 객체의 프로퍼티 중 Content로 표시할 프로퍼티 이름으로 설정한다.
  - ItemContainerStyle : ListBoxItem의 Style

- ItemTemplate : ListBoxItem의 ContentTemplate을 재정의하기 위한 DataTemplate (ItemsControl에서 상속됨)

- ItemsPresenter 사용 | Header, Footer 나타내는 예시
```csharp 
<Grid>
    <ListBox Style="{StaticResource ListBoxStyle}"
             Tag="데이터목록">
        <ListBoxItem>데이터1</ListBoxItem>
        <ListBoxItem>데이터2</ListBoxItem>
        <ListBoxItem>데이터3</ListBoxItem>
        <ListBoxItem>데이터4</ListBoxItem>
        <ListBoxItem>데이터5</ListBoxItem>
    </ListBox>
</Grid>

<Style TargetType="{x:Type ListBox}" x:Key="ListBoxStyle">
    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="{x:Type ListBox}">
                <Border>
                    <Grid>
                        <Grid.RowDefinitions>
                            <RowDefinition Height="Auto"/>
                            <RowDefinition Height="*"/>
                            <RowDefinition Height="Auto"/>
                        </Grid.RowDefinitions>
                        <Border BorderBrush="#aaaaaa"
                                BorderThickness="0 0 0 1"
                                Padding="10">
                            <TextBlock Grid.Row="0" Text="{TemplateBinding Tag}"/>
                        </Border>
                        <ItemsPresenter Grid.Row="1"/>
                        <Border BorderBrush="#aaaaaa"
                                BorderThickness="0 1 0 0"
                                Grid.Row="2"
                                Padding="10">
                            <StackPanel Orientation="Horizontal">
                                <Button Content="1"/>
                                <Button Content="2"/>
                                <Button Content="3"/>
                                <Button Content="4"/>
                                <Button Content="5"/>
                            </StackPanel>
                        </Border>
                    </Grid>
                </Border>
            </ControlTemplate>
        </Setter.Value>
    </Setter>
    <Setter Property="ItemsPanel">
        <Setter.Value>
            <ItemsPanelTemplate>
                <UniformGrid Columns="5"/>
            </ItemsPanelTemplate>
        </Setter.Value>
    </Setter>
</Style>
```


## 7. ListBoxItem
- 상속
  - Control > ContentControl > ListBoxItem
- ListBox 의 ItemTemplate을 설정하여 Content를 재정의할 수 있다.
- ListBox 의 ItemContainerStyle 설정하여 Style을 적용할 수 있다.
