// Reverse dict, exchange keys and values
'use strict';

const reverseObject = (object) => {
    const keys = Object.keys(object);
    for (let item of keys) {
        const newKey = object[item];
        object[newKey] = item;
        delete object[item];
    }
    return object;

};
  require('../Tests/reverse.js')(reverseObject);
