function Rectangle(number) {
    if (number == null) {
        for (let index = 0; index < 5; index++) {
            console.log('* '.repeat(5));
        }
    }
    else {
        for (let index = 0; index < number; index++) {
            console.log('* '.repeat(number));
        }
    }
}
Rectangle();