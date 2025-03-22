function updateHiddenInputs(form) {
    const row = form.closest('tr');
    const name = row.querySelector('td:nth-child(1)').innerText.trim();
    const department = row.querySelector('td:nth-child(2)').innerText.trim();

    form.querySelector('input[name="name"]').value = name;
    form.querySelector('input[name="department"]').value = department;
}

async function handleFormSubmit(event) {
    event.preventDefault(); // Prevent the default form submission
    const form = event.target;

    const formData = new FormData(form);
    const response = await fetch(form.action, {
        method: form.method,
        body: formData
    });

    if (response.ok) {
        await reloadTable(); // Reload the table content dynamically
        console.log("Action completed successfully.");
    } else {
        console.error("An error occurred while processing the request.");
    }
}

async function reloadTable() {
    const response = await fetch('?handler=Table'); // Fetch the updated table content
    if (response.ok) {
        const tableHtml = await response.text();
        document.querySelector('table').outerHTML = tableHtml; // Replace the table content
        attachAjaxHandlers(); // Reattach event handlers to the new forms
    }
}

function attachAjaxHandlers() {
    document.querySelectorAll("form.ajaxForm").forEach(form => {
        form.addEventListener("submit", handleFormSubmit);
    });
}

function onDelete(event) {
    const form = event.target;
    const name = form.closest('tr').children[0].innerText;
    const confirmed = confirm(`Are you sure you want to delete the employee ${name}?`);
    if (!confirmed) {
        event.preventDefault(); // Prevent the default action if the user cancels
    }

    return confirmed;
}

// Attach the handler to all forms with class 'ajaxForm'
document.addEventListener("DOMContentLoaded", attachAjaxHandlers);
