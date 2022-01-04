// Finde an intersection of two dictionaries
'use strict'
const dictIntersection =(firstDict,secDict)=> {
  const firstDictKeys = Object.keys(firstDict);
 for (let element of firstDictKeys){
if (element !== '' && secDict[element]) {
    secDict[element] = firstDict[element];
} else 
delete firstDict[element]; 
}
return firstDict;
}

const result = dictIntersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
