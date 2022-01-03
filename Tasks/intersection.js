// Finde an intersection of two dictionaries

intersection=function intersection(first,second)  {
  firstKeys = Object.keys(first);                    
  for (attributeName of firstKeys) {
    if (attributeName !== '' && second[attributeName]) {
      second[attributeName] = first[attributeName];   
    } else {
      delete first[attributeName];
    }
  }
  return first;
}

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
