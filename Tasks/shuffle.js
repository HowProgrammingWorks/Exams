// Shuffle an array

function shuffle( ...List) {
  const [arr] = List;
  arr.sort(() => Math.random() - 0.5);
  return arr;
}

console.log(shuffle(['a', 'b', 'c', 'd', 'e']));
