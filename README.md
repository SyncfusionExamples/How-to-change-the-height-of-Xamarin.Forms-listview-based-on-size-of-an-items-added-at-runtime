# How to change the height of Xamarin.Forms listview based on size of an items added at runtime?

This example demonstrates how to change the height of Xamarin.Forms listview based on size of an items added at runtime.

## Sample

```xaml
<StackLayout>
    <Button Text="Add item" Clicked="Button_Clicked"/>
    <syncfusion:SfListView x:Name="listView" BackgroundColor="Azure" 
                        ItemSpacing="3" ItemSize="70" ItemsSource="{Binding contactsinfo}">
        <syncfusion:SfListView.ItemTemplate>
            <DataTemplate>
                <ViewCell>
                    <ViewCell.View>
                        <Grid x:Name="grid" RowSpacing="1">
                            <Grid.RowDefinitions>
                                <RowDefinition Height="*" />
                                <RowDefinition Height="1" />
                            </Grid.RowDefinitions>
                            <Grid RowSpacing="1">
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="50" />
                                    <ColumnDefinition Width="*" />
                                    <ColumnDefinition Width="70" />
                                </Grid.ColumnDefinitions>
                                <Grid>
                                    <Image Source="{Binding ContactImage}"
                                            VerticalOptions="Center"
                                            HorizontalOptions="Center"
                                            HeightRequest="50"/>
                                </Grid>
                                <Grid Grid.Column="1"
                                        RowSpacing="1"
                                        Padding="10,0,0,0"
                                        VerticalOptions="Center">
                                    <Grid.RowDefinitions>
                                        <RowDefinition Height="*" />
                                        <RowDefinition Height="*" />
                                    </Grid.RowDefinitions>
                                    <Label LineBreakMode="WordWrap"
                                            TextColor="#474747"
                                            Text="{Binding ContactName}">
                                    </Label>
                                    <Label Grid.Row="1"
                                            Grid.Column="0"
                                            TextColor="#474747"
                                            Text="{Binding ContactNumber}">
                                    </Label>
                                </Grid>
                            </Grid>
                            <StackLayout Grid.Row="1" BackgroundColor="Gray" HeightRequest="1"/>
                        </Grid>
                    </ViewCell.View>
                </ViewCell>
            </DataTemplate>
        </syncfusion:SfListView.ItemTemplate>
    </syncfusion:SfListView>
</StackLayout>

Code behind:
visualContainer = listView.GetVisualContainer();
visualContainer.PropertyChanged += VisualContainer_PropertyChanged;

private void VisualContainer_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
{
        if (e.PropertyName == "Height" && this.HeightRequest != visualContainer.Height)
            listView.HeightRequest = visualContainer.Height;
}

private void Button_Clicked(object sender, EventArgs e)
{
    Random r=new Random();
    var contact = new Contacts();
    contact.ContactName = "Irene";
    contact.ContactNumber = "123-4056";
    contact.ContactImage = ImageSource.FromResource("SfListViewSample.Images.Image" + r.Next(0, 28) + ".png");
    viewModel.contactsinfo.Add(contact);
}
```

See [How to change the height of Xamarin.Forms listview based on size of an items added at runtime?](https://www.syncfusion.com/kb/9816/how-to-change-the-height-of-xamarin-forms-listview-based-on-size-of-an-items) for more details.

## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
