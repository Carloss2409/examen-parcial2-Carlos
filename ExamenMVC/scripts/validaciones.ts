function mostrarError(id: string, mensaje: string) {
    const span = document.getElementById(id);
    if (span) {
        span.textContent = mensaje;
        span.style.color = "red";
    }
}

function limpiarError(id: string) {
    const span = document.getElementById(id);
    if (span) {
        span.textContent = "";
    }
}

document.getElementById("formAlumnos")?.addEventListener("submit", function(event) {
    event.preventDefault();
    let valido = true;

    const nombre = (document.getElementById("nombre") as HTMLInputElement).value;
    const carrera = (document.getElementById("carrera") as HTMLSelectElement).value;

    limpiarError("errorNombre");
    limpiarError("errorCarrera");

    if (!nombre) {
        mostrarError("errorNombre", "El nombre es obligatorio");
        valido = false;
    }

    if (!carrera) {
        mostrarError("errorCarrera", "Selecciona una carrera");
        valido = false;
    }

    if (valido) {
        alert("Formulario válido"); // Aquí puedes enviar datos a tu API
    }
});
