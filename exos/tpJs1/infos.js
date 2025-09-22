document.addEventListener("DOMContentLoaded", () => {
  const btn = document.getElementById("btn");
  const result = document.getElementById("result");

  btn.addEventListener("click", () => {
    const nom = document.getElementById("nom").value.trim();
    const prenom = document.getElementById("prenom").value.trim();
    const ageValue = document.getElementById("age").value.trim();
    const age = Number(ageValue);

    let status;

    if (isNaN(age) || age < 0 || age > 120) {
      status = "Erreur (âge invalide)";
    } else if (age < 18) {
      status = "Mineur";
    } else if (age >= 18 && age < 50) {
      status = "Majeur";
    } else {
      status = "Senior";
    }

    const recap = `
      NOM: ${nom.toUpperCase()}, PRENOM: ${prenom}<br>
      AGE: ${age}<br>
      STATUS: ${status}
    `;

    result.innerHTML = recap;
  });
});
