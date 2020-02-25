@ModelType lab_44_mvc_framework.lab_44_mvc_framework.Category
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Category</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.CategoryName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CategoryName)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.CategoryID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
