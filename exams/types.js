types = function (s) {
    const types = {
        number: 0,
        string: 0,
        boolean: 0,
    };
    for (i of s) {
        const symbol = typeof i;
        if (symbol in types) {
            types[symbol]++;
        }
    }
    return types;

};
require('../Tests/types.js')(types);