$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/event/getall' },
        "columns": [
            {
                "data": "startDateTime",
                "render": function (data) {
                    return new Date(data).toLocaleDateString('en-US', { month: 'short', day: '2-digit', year: 'numeric' });
                }
            },
            {
                "data": "endDateTime",
                "render": function (data, type, row) {
                    var start = new Date(row.startDateTime).toLocaleTimeString('en-US', { hour: 'numeric', minute: '2-digit' });
                    if (data) {
                        var end = new Date(data).toLocaleTimeString('en-US', { hour: 'numeric', minute: '2-digit' });
                        return start + " – " + end;
                    }
                    return start;
                }
            },
            { "data": "name" },
            { "data": "type" },
            {
                data: 'status',
                render: function (data) {
                    const badges = {
                        'Upcoming': '<span class="badge badge-upcoming">Upcoming</span>',
                        'Ongoing': '<span class="badge badge-ongoing">Ongoing</span>',
                        'Completed': '<span class="badge badge-completed">Completed</span>'
                    };
                    return badges[data] ?? '<span class="badge badge-secondary">' + data + '</span>';
                }
            },
            {
                "data": "id",
                "render": function (data) {
                    return `<a href="/Event/Edit/${data}" class="btn btn-warning btn-sm">Edit</a>
                            <a href="/Event/Delete/${data}" class="btn btn-danger btn-sm">Delete</a>`;
                }
            }
        ]
    });
}
