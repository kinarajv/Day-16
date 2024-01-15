using System;
public class GameController : IDisposable
{
	public Piece piece;
	public Card card;
	public FileStream file;
	private bool disposedValue; //Default : False

	protected virtual void Dispose(bool disposing)
	{
		if (!disposedValue) //Apakah Dispose() pernah dipanggil atau tidak?
		{
			if (disposing) //if true, then release managed object
			{
				piece = null;
				card = null;
			}

			// TODO: free unmanaged resources (unmanaged objects) and override finalizer
			// TODO: set large fields to null
			file.Dispose();
			file = null;
			disposedValue = true; //For give state that Dispose() already called
		}
	}

	// TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
	~GameController()
	{
		file.Dispose();
		// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		Dispose(true);
		GC.SuppressFinalize(this);
	}
}

public class Card
{
}

public class Piece
{
}