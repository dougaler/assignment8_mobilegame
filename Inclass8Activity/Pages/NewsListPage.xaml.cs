using Inclass8Activity.Models;
using Inclass8Activity.Services;

namespace Inclass8Activity.Pages;

public partial class NewsListPage : ContentPage
{
	public List<Article> ArticleList;
	public string categoryName;
	public NewsListPage(Category item)
	{
		InitializeComponent();
		LblCategoryName.Text = item.Name;
		GetBreakingNews(item.Name);
		ArticleList = new List<Article>();
	}
	private async Task GetBreakingNews(string categoryName)
	{
		var apiService = new APIService();
		var newsResult = await apiService.GetNews(categoryName);
		foreach (var item in newsResult.Articles)
		{
			ArticleList.Add(item);
		}
		CvNews.ItemsSource = ArticleList;
	}

	private void CvNews_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		var selectedItems = e.CurrentSelection.FirstOrDefault() as Article;
		if (selectedItems == null) return;
		Navigation.PushAsync(new NewsDetailPage(selectedItems));
		((CollectionView)sender).SelectedItems = null;
	}
}