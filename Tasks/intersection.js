'use strict'
// Find an intersection of two dictionaries

const intersection = (object1, object2) => {
  const key = Object.keys(object1)
  for (const name of key) {
    if (name !== '' && object2[name]) {
      object2[name] = object1[name]
    } else {
      delete object1[name]
    }
  }
  return object1
}
const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' })
console.log(result)
