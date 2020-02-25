@ModelType lab_44_mvc_framework.lab_44_mvc_framework.User
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>User</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.UserName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UserName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DateOfBirth)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DateOfBirth)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.isValid)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.isValid)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Category.CategoryName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Category.CategoryName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Company.CompanyName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Company.CompanyName)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.UserID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
