import express from 'express';
import cors from 'cors';
import watchlistRoutes from './routes/watchlist.js';

const app = express();

app.use(cors());
app.use(express.json());

app.use('/api', watchlistRoutes);

const PORT = process.env.PORT || 3000;
app.listen(PORT, () => console.log(`Server running on port ${PORT}`));
