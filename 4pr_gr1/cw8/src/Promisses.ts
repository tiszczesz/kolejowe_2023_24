const delay2 = (t: number, info: string) => {
    return new Promise<void>((res) => {
        setTimeout(() => {
            console.log(info);
            res();
        }, t)
    })
}
delay2(4000, "Zadanie 1")
    .then((res) => {
        return delay2(3000, "zadanie 2")
    })
    .then((res) => {
        return delay2(200, "zadanie 3")

    }).then((res) => {
        return delay2(100, "zadanie 4")
    })