export const getRandomItem = (item) => {
  return item[Math.floor(Math.random() * item.length)];
};
