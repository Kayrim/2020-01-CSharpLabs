@ModelType IEnumerable(Of lab_44_mvc_framework.lab_44_mvc_framework.Company)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.CompanyName)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CompanyName)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.CompanyID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.CompanyID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.CompanyID })
        </td>
    </tr>
Next

</table>
