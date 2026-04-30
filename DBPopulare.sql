USE SalaFIT

INSERT INTO Clienti (IdClient, NumePrenume, DataNasterii, Telefon, Email) VALUES
(1, 'Ion Popescu', '1998-05-12', '0691234567', 'ion.popescu@gmail.com'),
(2, 'Maria Rusu', '2000-11-23', '0682345678', 'maria.rusu@yahoo.com'),
(3, 'Andrei Munteanu', '1995-07-08', '0673456789', 'andrei.m@gmail.com'),
(4, 'Elena Ceban', '2002-03-15', '0794567890', 'elena.ceban@mail.com'),
(5, 'Victor Damian', '1997-09-30', '0605678901', 'victor.d@gmail.com'),
(6, 'Ana Moraru', '2001-01-18', '0786789012', 'ana.moraru@yahoo.com');

INSERT INTO Abonamente (IdAbonament, Tip, Pret, GradAcces) VALUES
(1, 'Basic', 300, 1),
(2, 'Standard', 500, 2),
(3, 'Premium', 800, 3),
(4, 'Student', 250, 1),
(5, 'VIP', 1200, 4),
(6, 'Family', 900, 3);

INSERT INTO InregistrareAbonament (Id, IdClient, IdAbonament, DataStart, DataFinish) VALUES
(1, 1, 2, '2026-01-01', '2026-02-01'),
(2, 2, 3, '2026-01-10', '2026-02-10'),
(3, 3, 1, '2026-02-01', '2026-03-01'),
(4, 4, 4, '2026-02-15', '2026-03-15'),
(5, 5, 5, '2026-03-01', '2026-04-01'),
(6, 6, 6, '2026-03-10', '2026-04-10'),
(7, 1, 3, '2026-04-01', '2026-05-01'),
(8, 2, 1, '2026-04-15', '2026-05-15');