$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $('#eventsTable').DataTable({
        "ajax": { url: '/event/getall' },
        "language": {
            "search": "",
            "searchPlaceholder": "Search events..."
        },
        "dom": "<'row align-items-center table-title'<'col-auto'><'col-auto'f><'col'>>,rt<'row align-items-center mt-2'<'col'i><'col-auto'l>>",
        "columns": [
            {
                data: "startDateTime",
                width: "15%",
                render: function (data) {
                    const date = new Date(data);
                    const day = date.toLocaleDateString('en-US', { weekday: 'short' }).toUpperCase();
                    const rest = date.toLocaleDateString('en-US', { month: 'short', day: '2-digit', year: 'numeric' });
                    return '<span style="font-weight: 700;">' + day + '</span>, ' + '<span style="font-size: 0.85rem; color: #6B7280">' + rest + '</span>';
                }
            },
            {
                data: "endDateTime",
                width: "20%",
                render: function (data, type, row) {
                    var start = new Date(row.startDateTime).toLocaleTimeString('en-US', { hour: 'numeric', minute: '2-digit' });
                    var time = data
                        ? start + " – " + new Date(data).toLocaleTimeString('en-US', { hour: 'numeric', minute: '2-digit' })
                        : start;
                    return '<span style="color: #6B7280;">' + time + '</span>';
                }
            },
            {
                "data": "name",
                "width": "25%",
                "orderable": false,
                "render": function (data) {
                    return '<span style="font-weight: 700; color: #2e2e2e">' + data + '</span>';
                }
            },
            {
                "data": "type",
                "width": "20%",
                "render": function (data) {
                    return '<span style="color: #6B7280">' + data + '</span>';
                }
            },
            {
                "data": "status",
                "width": "15%",
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
                "targets": -1,
                "orderable": false,
                "width": "5%",
                "searchable": false,
                "render": function (data, type, row) {
                    return `
                        <div class="dropdown">
                            <button class="btn btn-link text-secondary p-0" 
                                    type="button" 
                                    data-toggle="dropdown" 
                                    aria-haspopup="true" 
                                    aria-expanded="false">
                                <i class="fas fa-ellipsis-v fa-lg"></i>
                            </button>
                            <div class="dropdown-menu dropdown-menu-right shadow-sm">
                                <a class="dropdown-item edit-event" href="#" data-id="${row.id}">
                                    Edit
                                </a>
                                <div class="dropdown-divider"></div>
                                <a class="dropdown-item delete-event" href="#" data-id="${row.id}">
                                    Delete
                                </a>
                            </div>
                        </div>`;
                }
            }

        ],
        "initComplete": function () {
            $('#eventsTable_wrapper .row:first-child')
                .prepend('<div class="col-auto"><h1 class="font-weight-bold mb-0 mr-4">Events</h1></div>');

            $('#eventsTable_wrapper .row:first-child .col')
                .addClass('d-flex justify-content-end align-items-center')
                .append('<a href="/Event/Create" class="btn btn-primary add-event"><i class="fas fa-plus mr-2"></i> Add Event</a>');

            $('#eventsTable').css('overflow', 'visible');
            $('#eventsTable').closest('.dataTables_wrapper').css('overflow', 'visible');
        }
    });
}
