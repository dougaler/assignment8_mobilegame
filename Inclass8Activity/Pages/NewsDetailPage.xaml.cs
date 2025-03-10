using Inclass8Activity.Models;

namespace Inclass8Activity.Pages;

public partial class NewsDetailPage : ContentPage
{
	public NewsDetailPage(Article newsArticle)
	{
		InitializeComponent();
		Img_NewsThumbnail.Source = newsArticle.Image;
		Lbl_NewsTitle.Text = newsArticle.Title;
		Lbl_NewsContent.Text = newsArticle.Content;

	}
}