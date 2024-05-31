SELECT *
FROM Boards
JOIN Columns on Boards.Id = Columns.BoardId
JOIN Cards ON Columns.Id = Cards.ColumnId