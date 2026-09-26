(() => {
  const toggle = document.querySelector(".menu-toggle");
  const menu = document.getElementById("site-menu");
  if (!toggle || !menu) return;

  const setOpen = open => {
    toggle.setAttribute("aria-expanded", String(open));
    menu.classList.toggle("is-open", open);
  };

  toggle.addEventListener("click", () => setOpen(toggle.getAttribute("aria-expanded") !== "true"));
  menu.addEventListener("click", e => { if (e.target.closest("a")) setOpen(false); });
  document.addEventListener("keydown", e => {
    if (e.key === "Escape" && menu.classList.contains("is-open")) {
      setOpen(false);
      toggle.focus();
    }
  });
  document.addEventListener("click", e => {
    if (!menu.contains(e.target) && !toggle.contains(e.target)) setOpen(false);
  });
  matchMedia("(min-width: 901px)").addEventListener("change", e => { if (e.matches) setOpen(false); });
})();
