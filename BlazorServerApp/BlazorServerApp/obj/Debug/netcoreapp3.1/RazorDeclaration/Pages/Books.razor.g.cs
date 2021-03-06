// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServerApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\Pages\Books.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\Pages\Books.razor"
using BlazorServerApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\Pages\Books.razor"
using CuriousDriveRazorLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\Pages\Books.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\Pages\Books.razor"
using BlazorServerApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/books")]
    public partial class Books : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\Pages\Books.razor"
        public Book book { get; set; }
    public List<Book> bookList { get; set; }
    public List<Book> filteredBookList { get; set; }
    public string SelectedCity { get; set; }

    public bool IsVisible { get; set; }
    public bool Result { get; set; }
    public string RecordName { get; set; }
    public string[] Cities { get; set; }
    public bool IsGridViewFiltered { get; set; }
    bool isLoading = true;

    ElementReference firstNameTextBox;

    protected override void OnInitialized()
    {
        Console.WriteLine("Books - OnInitialized");
        base.OnInitialized();
    }

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("Books - OnInitializedAsync");

        book = new Book();
        bookList = new List<Book>();
        //authorList = await authorService.GetAuthors();

        await base.OnInitializedAsync();
    }

    protected override void OnParametersSet()
    {
        Console.WriteLine("Books - OnParametersSet");
        base.OnParametersSet();
    }

    protected override async Task OnParametersSetAsync()
    {
        Console.WriteLine("Books - OnParametersSetAsync");
        await base.OnParametersSetAsync();
    }

    protected override bool ShouldRender()
    {
        base.ShouldRender();
        Console.WriteLine("Books - ShouldRender");

        return true;
    }

    protected override void OnAfterRender(bool firstRender)
    {
        Console.WriteLine("Books - OnAfterRender - firstRender = " + firstRender);
        base.OnAfterRender(firstRender);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        Console.WriteLine("Books - OnAfterRenderAsync - firstRender = " + firstRender);

        if (firstRender)
        {
            await LoadBooks();

            isLoading = false;
            StateHasChanged();
        }

        await base.OnAfterRenderAsync(firstRender);
    }

    public void Dispose()
    {
        Console.WriteLine("Books - Dispose");
    }

    private async Task LoadBooks()
    {
        await Task.Delay(500);

        bookList = filteredBookList = await bookStoresService.GetAllAsync("books/GetBooks");//http ????????????
        if (bookList == null)
        {
            RefreshRequest refreshRequest = new RefreshRequest();
            refreshRequest.AccessToken = await localStorageService.GetItemAsync<string>("accessToken");
            refreshRequest.RefreshToken = await localStorageService.GetItemAsync<string>("refreshToken");

            var user1 = await userService.RefreshTokenAsync(refreshRequest);
            await localStorageService.SetItemAsync("accessToken", user1.AccessToken);

            bookList = filteredBookList = await bookStoresService.GetAllAsync("books/GetBooks");
        }

        StateHasChanged();
    }



    private void OnBooksrSearchTextChanged(ChangeEventArgs changeEventArgs, string columnTitle)
    {
        string searchText = changeEventArgs.Value.ToString();
        IsGridViewFiltered = true;
        if (searchText != null)
        {
            switch (columnTitle)
            {
                case "Title":
                    filteredBookList = bookList.Where(auth => auth.Title.ToString().Contains(searchText)).ToList();
                    break;
                case "Notes":
                    filteredBookList = bookList.Where(auth => auth.Notes.ToString().Contains(searchText)).ToList();
                    break;
                case "Types":
                    filteredBookList = bookList.Where(auth => auth.Type.ToString().Contains(searchText)).ToList();
                    break;
                case "Price":
                    filteredBookList = bookList.Where(auth => auth.Price.ToString().Contains(searchText)).ToList();
                    break;
                case "PublishedDate":
                    filteredBookList = bookList.Where(auth => auth.PublishedDate.ToString().Contains(searchText)).ToList();
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }


    }

    async Task TakeBook(Book book)
    {
        if (book.book_quantity <= 0)
            return;
        BookUser bookUser = new BookUser();
        bookUser.BookId = book.BookId;
        var state = await provider.GetAuthenticationStateAsync();
        bookUser.UserId = int.Parse(state.User.FindFirst("id").Value);
        bookUser.Dataofloan = DateTime.Now;
        bookUser.Deadline = bookUser.Dataofloan.Value.AddDays(7);
        try
        {
            await bookUserService.SaveAsync("books/TakeBook", bookUser);
            book.book_quantity--;
            await bookStoresService.UpdateAsync("books/UpdateBook/", book.BookId, book);
        }
        catch
        {
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider provider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookStoresService<BookUser> bookUserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookStoresService<Book> bookStoresService { get; set; }
    }
}
#pragma warning restore 1591
