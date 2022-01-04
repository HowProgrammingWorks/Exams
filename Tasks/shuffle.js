// Shuffle an array

;let  Shuffle = ( ...List) => {;
  const [ arr ] = List;
  arr.sort(() => Math.random() - 0.5); { return arr }
}

const result = Shuffle(['a', 'b', 'c', 'd', 'e']);
console.log(result);
