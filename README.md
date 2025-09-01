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
                            . . .
                            . . .
                                <Grid>
                                    <Image Source="{Binding ContactImage}"
                                            VerticalOptions="Center"
                                            HorizontalOptions="Center"
                                            HeightRequest="50"/>
                                </Grid>
                                . . .
                                . . .
                            </Grid>
                            <StackLayout Grid.Row="1" BackgroundColor="Gray" HeightRequest="1"/>
                        </Grid>
                    </ViewCell.View>
                </ViewCell>
            </DataTemplate>
        </syncfusion:SfListView.ItemTemplate>
    </syncfusion:SfListView>
</StackLayout>

C#:
visualContainer = listView.GetVisualContainer();
visualContainer.PropertyChanged += VisualContainer_PropertyChanged;

private void VisualContainer_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
{
        if (e.PropertyName == "Height" && this.HeightRequest != visualContainer.Height)
            listView.HeightRequest = visualContainer.Height;
}
```

See [How to change the height of Xamarin.Forms listview based on size of an items added at runtime?](https://www.syncfusion.com/kb/9816/how-to-change-the-height-of-xamarin-forms-listview-based-on-size-of-an-items) for more details.

## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
