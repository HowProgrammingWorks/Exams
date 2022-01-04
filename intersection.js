// Finde an intersection of two dictionaries
'use strict'
const dictIntersection =(firstDict,secDict)=> {
  const firstDictKeys = Object.keys(firstDict);
  let result = {}
 for (let element of firstDictKeys){
if (firstDict[element] === secDict[element]) {
        result[element] = firstDict[element]
} 
}
return result;
}

const result = dictIntersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
