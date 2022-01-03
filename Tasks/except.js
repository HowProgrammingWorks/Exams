// Copy all values from dict except listed

const except = (obj,...args) => {
    const keys = Object.keys(obj);
    keys.forEach((key) => {
        if (args.includes(key)) {
            delete obj[key];
        }
    }, 2000);
    return obj;
}

const result = except({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);
