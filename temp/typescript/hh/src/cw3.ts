document.querySelector("#run")?.addEventListener("click", (e) => {
    const elmA: HTMLInputElement | null = document.querySelector("#a");
    const elmB: HTMLInputElement | null = document.querySelector("#b");
    if (elmA === null || elmB === null) {
        console.log('error');
        return;
    }
    const a = elmA !== null ? parseFloat(elmA.value) : 0;

    const result = document.querySelector("#result");
    const b = elmB !== null ? parseFloat(elmB.value) : 0;
    if (isNaN(a) || isNaN(b)) {
        result!.innerHTML = "Błędne dane";
    } else {
        result!.innerHTML = `${a} + ${b} = ${a + b}`;
    }

});