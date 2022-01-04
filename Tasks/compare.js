// Compare two dictionaries

const compareDictionaries = function( obj1,obj2 ) {
  const obj1Keys = Object.keys(obj1).sort();
  const obj2Keys = Object.keys(obj2).sort();

  if (obj1Keys.join('-') !== obj2Keys.join('-')) return false;

  let e = true;

  for ( const key of obj1Keys ) {
    if ( obj1[key] === obj2[key] ) e = e && true;
    else { e = e && false; }
  }

  return e;
};

const result = compare({ a: 1, c: 'hello' }, { a: 1, c: 'hello' });
console.log(result);
