const API_URL = "http://127.0.0.1:5500/json/task1.html";
$(document).ready(function () {

    let students = [];
    let currentPage = 1;
    const recordsPerPage = 5;
    $("#studentForm").submit(function (e) {
        e.preventDefault();

        let id = $("#studentId").val();
        let name = $("#name").val().trim();
        let age = $("#age").val();
        let grade = $("#grade").val();

        if (name === "" || age === "" || grade === "") {
            alert("All fields are required!");
            return;
        }

        if (id === "") {
            students.push({
                id: Date.now(),
                name,
                age,
                grade
            });
        } else {
            let student = students.find(s => s.id == id);
            student.name = name;
            student.age = age;
            student.grade = grade;
            $("#studentId").val("");
        }

        $("#studentForm")[0].reset();
        displayStudents();
    });
    function displayStudents() {

        let searchText = $("#searchInput").val().toLowerCase();
        let filterGrade = $("#filterGrade").val();

        let filtered = students.filter(s =>
            s.name.toLowerCase().includes(searchText) &&
            (filterGrade === "" || s.grade === filterGrade)
        );

        let start = (currentPage - 1) * recordsPerPage;
        let paginated = filtered.slice(start, start + recordsPerPage);

        $("#studentTable").empty();

        $.each(paginated, function (index, s) {
            $("#studentTable").append(`
                <tr>
                    <td>${s.id}</td>
                    <td>${s.name}</td>
                    <td>${s.age}</td>
                    <td>${s.grade}</td>
                    <td>
                        <button class="editBtn" data-id="${s.id}">Edit</button>
                        <button class="deleteBtn" data-id="${s.id}">Delete</button>
                    </td>
                </tr>
            `);
        });

        setupPagination(filtered.length);
    }
    $(document).on("click", ".editBtn", function () {
        let id = $(this).data("id");
        let student = students.find(s => s.id == id);

        $("#studentId").val(student.id);
        $("#name").val(student.name);
        $("#age").val(student.age);
        $("#grade").val(student.grade);
    });
    $(document).on("click", ".deleteBtn", function () {
        if (confirm("Are you sure you want to delete?")) {
            let id = $(this).data("id");
            students = students.filter(s => s.id != id);
            displayStudents();
        }
    });
    $("#searchInput").on("keyup", function () {
        currentPage = 1;
        displayStudents();
    });
    $("#filterGrade").change(function () {
        currentPage = 1;
        displayStudents();
    });
    function setupPagination(totalRecords) {

        $(".pagination").empty();
        let totalPages = Math.ceil(totalRecords / recordsPerPage);

        for (let i = 1; i <= totalPages; i++) {
            $(".pagination").append(
                `<button class="pageBtn ${i === currentPage ? 'activePage' : ''}" data-page="${i}">${i}</button>`
            );
        }
    }

    $(document).on("click", ".pageBtn", function () {
        currentPage = Number($(this).data("page"));
        displayStudents();
    });

});