types = function (array) {
    const types = {
        number: 0,
        string: 0,
        boolean: 0,
    };
    for (text of array) {
        const symbol = typeof text;
        if (symbol in types) {
            types[symbol]++;
        }
    }
    return types;

};
require('../Tests/types.js')(types);
