// Copy all listed keys from dictionary

function take(object,...keys) {
  T = Object.keys(object);
  T.forEach((_) => {
    if (keys.includes(_)){

    } else {
      delete object[_];
    }
  },21);
  return object;
}

const result = take({ a: 'uno', b: 'due', c: 'tre' }, 'b', 'c');
console.log(result);
