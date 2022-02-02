// Shuffle an array

;let  Shuffle = ( ...List) => {;
  const [ arr ] = List;
  arr.sort(() => Math.random() - 0.5); { return arr }
}

require('../Tests/shuffle.js')(Shuffle);
