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
#line 2 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\Pages\BooksUsers.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\Pages\BooksUsers.razor"
using BlazorServerApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\Pages\BooksUsers.razor"
using CuriousDriveRazorLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\Pages\BooksUsers.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\Pages\BooksUsers.razor"
using BlazorServerApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/BookUsers")]
    public partial class BooksUsers : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\vamdi\Desktop\BookStores\BlazorServerApp\BlazorServerApp\Pages\BooksUsers.razor"
        public BookUser bookuser { get; set; }
    public List<BookUser> bookuserList { get; set; }
    public List<BookUser> filteredBookUserList { get; set; }
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
        Console.WriteLine("BooksUsers - OnInitialized");
        base.OnInitialized();
    }

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("BooksUsers - OnInitializedAsync");

        bookuser = new BookUser();
        bookuserList = new List<BookUser>();
        //authorList = await authorService.GetAuthors();

        await base.OnInitializedAsync();
    }

    protected override void OnParametersSet()
    {
        Console.WriteLine("BooksUsers - OnParametersSet");
        base.OnParametersSet();
    }

    protected override async Task OnParametersSetAsync()
    {
        Console.WriteLine("BooksUsers - OnParametersSetAsync");
        await base.OnParametersSetAsync();
    }

    protected override bool ShouldRender()
    {
        base.ShouldRender();
        Console.WriteLine("BooksUsers - ShouldRender");

        return true;
    }

    protected override void OnAfterRender(bool firstRender)
    {
        Console.WriteLine("BooksUsers - OnAfterRender - firstRender = " + firstRender);
        base.OnAfterRender(firstRender);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        Console.WriteLine("BooksUsers - OnAfterRenderAsync - firstRender = " + firstRender);

        if (firstRender)
        {
            await LoadBooksUsers();

            isLoading = false;
            StateHasChanged();
        }

        await base.OnAfterRenderAsync(firstRender);
    }

    public void Dispose()
    {
        Console.WriteLine("BooksUsers - Dispose");
    }

    private async Task LoadBooksUsers()
    {
        await Task.Delay(500);
        var state = await provider.GetAuthenticationStateAsync();
        int UserId = int.Parse(state.User.FindFirst("id").Value);
        bookuserList = filteredBookUserList = await bookUserService.GetAllAsync("books/GetBookUsers/" + UserId);//http ????????????
        if (bookuserList == null)
        {
            RefreshRequest refreshRequest = new RefreshRequest();
            refreshRequest.AccessToken = await localStorageService.GetItemAsync<string>("accessToken");
            refreshRequest.RefreshToken = await localStorageService.GetItemAsync<string>("refreshToken");

            var user1 = await userService.RefreshTokenAsync(refreshRequest);
            await localStorageService.SetItemAsync("accessToken", user1.AccessToken);

            bookuserList = filteredBookUserList = await bookUserService.GetAllAsync("books/GetBookUsers/" + UserId);
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
                case "BookId":
                    filteredBookUserList = bookuserList.Where(auth => auth.Book.Title.ToString().Contains(searchText)).ToList();
                    break;
                case "Dataofloan":
                    filteredBookUserList = bookuserList.Where(auth => auth.Dataofloan.ToString().Contains(searchText)).ToList();
                    break;
                case "Deadline":
                    filteredBookUserList = bookuserList.Where(auth => auth.Deadline.ToString().Contains(searchText)).ToList();
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }


    }

    async Task ReturnBook(BookUser bookuser)
    {

        try
        {
            await bookUserService.DeleteAsync("books/DeleteBookUser/" + bookuser.BookId + "/", bookuser.UserId);
            bookuser.Book.book_quantity++;
            await bookStoresService.UpdateAsync("books/UpdateBook/", bookuser.BookId, bookuser.Book);

        }
        catch
        {
        }
        await LoadBooksUsers();
        StateHasChanged();
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
