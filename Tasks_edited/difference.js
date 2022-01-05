// Finde a difference of two dictionaries

function diff(dictionary1, dictionary2){
    for(const index in dictionary2){
        dictionary1[index] = dictionary2[index]
        delete dictionary1[index]
    }
    return dictionary1
}

const result = diff({a: 'uno', b: 'due'}, {a: 'uno', c: 'tre'});
console.log(result);
