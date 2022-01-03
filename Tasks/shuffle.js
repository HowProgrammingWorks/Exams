// Shuffle an array

const shuffle = (...List) => {
  const [arr] = List;
  arr.sort(() => Math.random() - 0.5);
  return arr;
}

const result = shuffle(['a', 'b', 'c', 'd', 'e'])
console.log(result);