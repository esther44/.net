document.addEventListener("DOMContentLoaded", () => {
  const nombreMystere = Math.floor(Math.random() * 10) + 1;
  let coups = 0;

  const btn = document.getElementById("btn");
  const result = document.getElementById("result");

  btn.addEventListener("click", () => {
    const valeur = Number(document.getElementById("proposition").value.trim());

    if (!valeur || valeur < 1 || valeur > 10) {
      result.textContent = "Entrez un nombre entre 1 et 10.";
      return;
    }

    coups++;

    if (valeur === nombreMystere) {
      result.textContent = `Bravo ! Vous avez trouvé en ${coups} coups.`;
      btn.disabled = true; 
    } else {
      result.textContent = "Mauvais choix, essayez encore...";
    }
  });
});
