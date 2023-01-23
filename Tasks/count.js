// Sum all number values in dict
'use strict';

const sum = (obj) => {
    let result = 0;
        const values = Object.values(obj);
        for(const value of values) {
            if (typeof value === 'number') result += value;
        }
        return result;
    };

require('../Tests/count.js')(sum)
