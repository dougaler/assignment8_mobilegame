using Inclass8Activity.Models;
using Inclass8Activity.Pages;
using Inclass8Activity.Services;

namespace Inclass8Activity;

public partial class NewsHomepage : ContentPage
{
	public List<Article> ArticleList;
	public List<Category> CategoryList = new List<Category>()
	{
		new Category(){Name = "World", ImageUrl = "world.png"},
		new Category(){Name = "Nation" , ImageUrl="nation.png"},
		new Category(){Name = "Business" , ImageUrl="business.png"},
		new Category(){Name = "Technology" , ImageUrl="technology.png"},
		new Category(){Name = "Entertainment", ImageUrl = "entertainment.png"},
		new Category(){Name = "Sports" , ImageUrl="sports.png"},
		new Category(){Name = "Science", ImageUrl= "science.png"},
		new Category(){Name = "Health", ImageUrl="health.png"},
	};

	public NewsHomepage()
	{
		InitializeComponent();
		ArticleList = new List<Article>();
		CvCategories.ItemsSource = CategoryList;
	}

	private void LVCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		var selectedItems = e.CurrentSelection.FirstOrDefault() as Category;
		if (selectedItems == null) return;
		Navigation.PushAsync(new NewsListPage(selectedItems));
		((CollectionView)sender).SelectedItems = null;
	}
}