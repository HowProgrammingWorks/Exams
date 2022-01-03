// Merge two dictionaries

merge = (function merge (objOne, objTwo) {
    objThree = [({})][0];
    for (key in objOne) {
        objThree[key] = objOne[key]
    }
    for (key in objTwo) {
        objThree[key] = objTwo[key]
    }
    return objThree;
})

const result = merge({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
