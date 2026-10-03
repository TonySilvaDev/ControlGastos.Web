document.addEventListener("DOMContentLoaded", function () {

    const sidebar = document.getElementById("sidebar");
    const sidebarToggle = document.getElementById("sidebarToggle");
    const sidebarClose = document.getElementById("sidebarClose");
    const sidebarOverlay = document.getElementById("sidebarOverlay");


    function openSidebar() {

        if (!sidebar) return;

        sidebar.classList.add("show");
        sidebarOverlay?.classList.add("show");

        document.body.style.overflow = "hidden";
    }


    function closeSidebar() {

        if (!sidebar) return;

        sidebar.classList.remove("show");
        sidebarOverlay?.classList.remove("show");

        document.body.style.overflow = "";
    }


    sidebarToggle?.addEventListener("click", function () {
        openSidebar();
    });


    sidebarClose?.addEventListener("click", function () {
        closeSidebar();
    });


    sidebarOverlay?.addEventListener("click", function () {
        closeSidebar();
    });


    /*
     * Al cambiar a escritorio,
     * limpiamos el estado del menú móvil.
     */
    window.addEventListener("resize", function () {

        if (window.innerWidth >= 992) {
            closeSidebar();
        }

    });


    /*
     * Cerrar el sidebar después de seleccionar
     * una opción en móvil.
     */
    document.querySelectorAll(".nav-item-link").forEach(function (link) {

        link.addEventListener("click", function () {

            if (window.innerWidth < 992) {
                closeSidebar();
            }

        });

    });

});