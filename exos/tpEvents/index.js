    const nom = document.getElementById("nom");
    const prenom = document.getElementById("prenom");
    const age = document.getElementById("age");
    const recap = document.getElementById("recap");
    const btn = document.getElementById("btn");

    nom.addEventListener("input", () => {
      nom.value = nom.value.toUpperCase();
    });

    prenom.addEventListener("input", () => {
      prenom.value = prenom.value.toLowerCase();
    });

    [nom, prenom].forEach(input => {
      input.addEventListener("blur", () => {
        if (input.value.trim() === "") {
          input.classList.add("error");
        } else {
          input.classList.remove("error");
          input.classList.add("normal");
        }
      });
    });

    btn.addEventListener("click", () => {
      recap.innerHTML = "";

      const nomVal = nom.value.trim();
      const prenomVal = prenom.value.trim();
      const ageVal = parseInt(age.value, 10);

      let ok = true;

      if (!nomVal) {
        nom.classList.add("error");
        ok = false;
      }
      if (!prenomVal) {
        prenom.classList.add("error");
        ok = false;
      }
      if (isNaN(ageVal) || ageVal < 0 || ageVal > 120) {
        age.classList.add("error");
        ok = false;
      } else {
        age.classList.remove("error");
      }

      if (!ok) return;

      const ageClass = ageVal < 18 ? "green" : "red";

      recap.innerHTML = `
        <p>NOM : ${nomVal}</p>
        <p>PRENOM : ${prenomVal}</p>
        <p class="${ageClass}">AGE : ${ageVal}</p>
      `;
    });