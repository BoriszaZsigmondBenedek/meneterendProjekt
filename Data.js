const data = [
    [1, 0, 5, 45, "I"],
    [1, 1, 6, 0, "E"],
    [1, 1, 6, 2, "I"],
    [1, 2, 6, 12, "E"],
    [1, 2, 6, 13, "I"],
    [1, 3, 6, 32, "E"],
    [1, 3, 6, 34, "I"],
    [2, 0, 6, 45, "I"],
    [1, 4, 6, 49, "E"],
    [1, 4, 6, 50, "I"],
    [2, 1, 6, 58, "E"],
    [1, 5, 7, 0, "E"],
    [2, 1, 7, 1, "I"],
    [1, 5, 7, 6, "I"],
    [2, 2, 7, 11, "E"],
    [2, 2, 7, 12, "I"],
    [1, 6, 7, 16, "E"],
    [1, 6, 7, 18, "I"],
    [2, 3, 7, 31, "E"],
    [2, 3, 7, 33, "I"],
    [3, 0, 7, 45, "I"],
    [1, 7, 7, 48, "E"],
    [2, 4, 7, 48, "E"],
    [1, 7, 7, 49, "I"],
    [2, 4, 7, 49, "I"],
    [1, 8, 7, 55, "E"],
    [1, 8, 7, 56, "I"],
    [3, 1, 7, 58, "E"],
    [2, 5, 7, 59, "E"],
    [2, 5, 8, 1, "I"],
    [1, 9, 8, 4, "E"],
    [3, 1, 8, 4, "I"],
    [1, 9, 8, 5, "I"],
    [2, 6, 8, 11, "E"],
    [1, 10, 8, 12, "E"],
    [2, 6, 8, 14, "I"],
    [3, 2, 8, 15, "E"],
    [3, 2, 8, 16, "I"],
    [3, 3, 8, 36, "E"],
    [3, 3, 8, 37, "I"],
    [2, 7, 8, 45, "E"],
    [2, 7, 8, 45, "I"],
    [4, 0, 8, 45, "I"],
    [2, 8, 8, 51, "E"],
    [3, 4, 8, 53, "E"],
    [2, 8, 8, 53, "I"],
    [3, 4, 8, 55, "I"],
    [4, 1, 8, 58, "E"],
    [2, 9, 9, 0, "E"],
    [2, 9, 9, 1, "I"],
    [3, 5, 9, 4, "E"],
    [3, 5, 9, 5, "I"],
    [4, 1, 9, 5, "I"],
    [2, 10, 9, 9, "E"],
    [3, 6, 9, 16, "E"],
    [4, 2, 9, 16, "E"],
    [3, 6, 9, 17, "I"],
    [4, 2, 9, 17, "I"],
    [4, 3, 9, 36, "E"],
    [4, 3, 9, 37, "I"],
    [5, 0, 9, 45, "I"],
    [3, 7, 9, 48, "E"],
    [3, 7, 9, 49, "I"],
    [4, 4, 9, 53, "E"],
    [3, 8, 9, 55, "E"],
    [3, 8, 9, 55, "I"],
    [4, 4, 9, 55, "I"],
    [5, 1, 9, 58, "E"],
    [3, 9, 10, 4, "E"],
    [4, 5, 10, 4, "E"],
    [3, 9, 10, 4, "I"],
    [4, 5, 10, 5, "I"],
    [5, 1, 10, 5, "I"],
    [3, 10, 10, 11, "E"],
    [4, 6, 10, 15, "E"],
    [5, 2, 10, 15, "E"],
    [5, 2, 10, 16, "I"],
    [4, 6, 10, 18, "I"],
    [5, 3, 10, 34, "E"],
    [5, 3, 10, 35, "I"],
    [6, 0, 10, 45, "I"],
    [4, 7, 10, 49, "E"],
    [5, 4, 10, 50, "E"],
    [4, 7, 10, 51, "I"],
    [5, 4, 10, 52, "I"],
    [4, 8, 10, 57, "E"],
    [4, 8, 10, 58, "I"],
    [6, 1, 10, 59, "E"],
    [5, 5, 11, 2, "E"],
    [6, 1, 11, 2, "I"],
    [5, 5, 11, 4, "I"],
    [4, 9, 11, 6, "E"],
    [4, 9, 11, 7, "I"],
    [6, 2, 11, 13, "E"],
    [4, 10, 11, 14, "E"],
    [5, 6, 11, 14, "E"],
    [6, 2, 11, 14, "I"],
    [5, 6, 11, 24, "I"],
    [6, 3, 11, 33, "E"],
    [6, 3, 11, 35, "I"],
    [7, 0, 11, 45, "I"],
    [6, 4, 11, 51, "E"],
    [6, 4, 11, 52, "I"],
    [7, 1, 11, 59, "E"],
    [5, 7, 12, 0, "E"],
    [5, 7, 12, 1, "I"],
    [7, 1, 12, 2, "I"],
    [6, 5, 12, 3, "E"],
    [5, 8, 12, 7, "E"],
    [5, 8, 12, 9, "I"],
    [6, 5, 12, 9, "I"],
    [7, 2, 12, 13, "E"],
    [7, 2, 12, 13, "I"],
    [5, 9, 12, 16, "E"],
    [5, 9, 12, 17, "I"],
    [6, 6, 12, 20, "E"],
    [6, 6, 12, 22, "I"],
    [5, 10, 12, 24, "E"],
    [7, 3, 12, 33, "E"],
    [7, 3, 12, 36, "I"],
    [8, 0, 12, 46, "I"],
    [7, 4, 12, 49, "E"],
    [7, 4, 12, 50, "I"],
    [8, 1, 12, 53, "E"],
    [8, 1, 12, 54, "I"],
    [7, 5, 12, 56, "E"],
    [7, 5, 12, 57, "I"],
    [9, 1, 13, 59, "E"],
    [8, 2, 13, 3, "E"],
    [8, 2, 13, 4, "I"],
    [9, 2, 13, 5, "I"],
    [7, 6, 13, 6, "E"],
    [7, 6, 13, 7, "I"],
    [7, 7, 13, 14, "E"],
    [8, 3, 13, 14, "E"],
    [9, 3, 13, 15, "E"],
    [8, 3, 13, 15, "I"],
    [9, 3, 13, 16, "I"],
    [9, 4, 13, 35, "E"],
    [9, 4, 13, 36, "I"],
    [10, 0, 13, 45, "I"],
    [8, 4, 13, 46, "E"],
    [8, 4, 13, 47, "I"],
    [9, 5, 13, 52, "E"],
    [8, 5, 13, 53, "E"],
    [8, 5, 13, 54, "I"],
    [9, 5, 13, 54, "I"],
    [10, 1, 13, 58, "E"],
    [8, 6, 14, 2, "E"],
    [9, 6, 14, 3, "E"],
    [8, 6, 14, 3, "I"],
    [9, 6, 14, 4, "I"],
    [10, 1, 14, 5, "I"],
    [8, 7, 14, 9, "E"],
    [10, 2, 14, 15, "E"],
    [9, 7, 14, 16, "E"],
    [10, 2, 14, 16, "I"],
    [9, 7, 14, 17, "I"],
    [10, 3, 14, 35, "E"],
    [10, 3, 14, 36, "I"],
    [11, 0, 14, 45, "I"],
    [9, 8, 14, 46, "E"],
    [9, 8, 14, 47, "I"],
    [10, 4, 14, 52, "E"],
    [10, 4, 14, 54, "I"],
    [9, 9, 14, 55, "E"],
    [9, 9, 14, 56, "I"],
    [11, 1, 14, 0, "E"],
    [9, 10, 14, 4, "E"],
    [10, 5, 14, 4, "E"],
    [11, 1, 14, 4, "I"],
    [9, 10, 14, 5, "I"],
    [10, 5, 14, 7, "I"],
    [9, 11, 14, 12, "E"],
    [11, 2, 14, 14, "E"],
    [11, 2, 14, 15, "I"],
    [10, 6, 14, 19, "E"],
    [10, 6, 14, 20, "I"],
    [11, 3, 14, 34, "E"],
    [11, 3, 14, 36, "I"],
    [12, 0, 14, 45, "I"],
    [10, 7, 14, 51, "E"],
    [10, 7, 14, 51, "I"],
    [11, 4, 14, 52, "E"],
    [11, 4, 14, 53, "I"],
    [10, 8, 14, 57, "E"],
    [10, 8, 14, 58, "I"],
    [12, 1, 15, 1, "E"],
    [11, 5, 15, 4, "E"],
    [12, 1, 15, 5, "I"]
];
