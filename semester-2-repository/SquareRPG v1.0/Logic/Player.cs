using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    enum MovementDirection
    {
        Null,
        Up,
        Right,
        Down,
        Left
    }

    public class Player
    {
        // Constants
        public const int XSize = 20;
        public const int YSize = 20;

        // Properties
        public int Health { get { return _health; } }
        public int XLocation { get { return _xLocation; } }
        public int YLocation { get { return _yLocation; } }
        public int TopBoundary { get { return _yLocation; } }
        public int RightBoundary { get { return _xLocation + XSize; } }
        public int BottomBoundary { get { return _yLocation + YSize; } }
        public int LeftBoundary { get { return _xLocation; } }
        public int AttackPower { get { return _attackPower; } }

        // Fields
        int _health = 5;
        int _attackPower = 1;
        int _xLocation = 21;
        int _yLocation = 21;
        int _movementSpeed = 2;
        MovementDirection _movementDirection;
        List<int[]> _boundariesList = Boundaries.BoundariesList;

        // Methods
        public void LoseHealth(int damage)
        {
            _health -= damage;
            if (_health < 0)
            {
                _health = 0;
            }
        }

        public void StopMoving()
        {
            _movementDirection = MovementDirection.Null;
        }

        public void MovementPlus()
        {
            if (_movementDirection == MovementDirection.Up)
            {
                MoveUpPlus();
            }
            if (_movementDirection == MovementDirection.Right)
            {
                MoveRightPlus();
            }
            if (_movementDirection == MovementDirection.Down)
            {
                MoveDownPlus();
            }
            if (_movementDirection == MovementDirection.Left)
            {
                MoveLeftPlus();
            }
        }
        public void MoveUpPlus()
        {
            _movementDirection = MovementDirection.Up;
            bool willCollide = false;

            foreach (var boundaries in _boundariesList)
            {
                if (TopBoundary == boundaries[2] || TopBoundary + 1 == boundaries[2])
                {
                    if (LeftBoundary < boundaries[1] && RightBoundary > boundaries[3])
                    {
                        willCollide = true;
                    }
                }
            }
            if (!willCollide)
            {
                _yLocation -= _movementSpeed;
            }
        }
        public void MoveRightPlus()
        {
            _movementDirection = MovementDirection.Right;
            bool willCollide = false;

            foreach (var boundaries in _boundariesList)
            {
                if (RightBoundary == boundaries[3] || RightBoundary - 1 == boundaries[3])
                {
                    if (TopBoundary < boundaries[2] && BottomBoundary > boundaries[0])
                    {
                        willCollide = true;
                    }
                }
            }
            if (!willCollide)
            {
                _xLocation += _movementSpeed;
            }
        }
        public void MoveDownPlus()
        {
            _movementDirection = MovementDirection.Down;
            bool willCollide = false;

            foreach (var boundaries in _boundariesList)
            {
                if (BottomBoundary == boundaries[0] || BottomBoundary - 1 == boundaries[0])
                {
                    if (LeftBoundary < boundaries[1] && RightBoundary > boundaries[3])
                    {
                        willCollide = true;
                    }
                }
            }
            if (!willCollide)
            {
                _yLocation += _movementSpeed;
            }
        }
        public void MoveLeftPlus()
        {
            _movementDirection = MovementDirection.Left;
            bool willCollide = false;

            foreach (var boundaries in _boundariesList)
            {
                if (LeftBoundary == boundaries[1] || LeftBoundary + 1 == boundaries[1])
                {
                    if (TopBoundary < boundaries[2] && BottomBoundary > boundaries[0])
                    {
                        willCollide = true;
                    }
                }
            }
            if (!willCollide)
            {
                _xLocation -= _movementSpeed;
            }
        }
    }
}
