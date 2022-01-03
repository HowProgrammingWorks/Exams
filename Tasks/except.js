// Copy all values from dict except listed

const except = (obj,...args) => {
    for (const key in obj) {
        if (args.includes(key)) {
            delete obj[key];
        }
    }
    return obj;
}

const result = except({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);
