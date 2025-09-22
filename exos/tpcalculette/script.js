function testCalcul(op) {
  const a = Number(document.getElementById("a").value);
  const b = Number(document.getElementById("b").value);

  if (isNaN(a) || isNaN(b)) {
    document.getElementById("result").textContent = "Entrez deux nombres valides.";
    return;
  }

  const resultat = calcul(op, a, b);
  document.getElementById("result").textContent = `Résultat : ${resultat}`;
}

function calcul(op, x, y) {
  switch (op) {
    case '+':
      return add(x, y);
    case '-':
      return sub(x, y);
    case '*':
      return mul(x, y);
    case '/':
      return div(x, y);
    default:
      return "Opération inconnue";
  }
}

function add(x, y) {
  return x + y;
}

function sub(x, y) {
  return x - y;
}

function mul(x, y) {
  return x * y;
}

function div(x, y) {
  if (y === 0) {
    return "Erreur : division par 0";
  }
  return x / y;
}
